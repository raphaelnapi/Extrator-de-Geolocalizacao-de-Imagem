using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extrator_de_Geolocalização_de_Imagem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        struct FileData
        {
            public string Filename;
            public string Filepath;
            public string Lat;
            public double Lat_Float;
            public string Long;
            public double Long_Float;
            public string Altitude;
            public string GPSProcessingMethod;
            public string Make;
            public string Model;
            public string DateTimeOriginal;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Arquivos suportados|*.jpg;*.jpeg;*.tif;*.tiff;*.png;*.webp",
                FilterIndex = 1,
                Multiselect = true,
                RestoreDirectory = true
            };
             
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                foreach(string filepath in dialog.FileNames)
                {
                    Image image = Image.FromFile(filepath);

                    FileData fileData = new FileData();
                    char ref_lat = '\0';
                    char ref_long = '\0';

                    fileData.Filepath = filepath;
                    fileData.Filename = filepath.Split('\\').Last();

                    foreach (PropertyItem prop in image.PropertyItems)
                    {
                        switch (prop.Id)
                        {
                            //Make
                            case 271:
                                fileData.Make = Encoding.ASCII.GetString(prop.Value);
                                fileData.Make = fileData.Make.Substring(0, fileData.Make.Length - 1); //remove o '\0' no final da String
                                break;
                            //Model
                            case 272:
                                fileData.Model = Encoding.ASCII.GetString(prop.Value);
                                fileData.Model = fileData.Model.Substring(0, fileData.Model.Length - 1); //remove o '\0' no final da String
                                break;
                            //DateTimeOriginal
                            case 36867:
                                fileData.DateTimeOriginal = Encoding.ASCII.GetString(prop.Value);
                                fileData.DateTimeOriginal = fileData.DateTimeOriginal.Substring(0, fileData.DateTimeOriginal.Length - 1); //remove o '\0' no final da String
                                break;
                            //Latitude Direction
                            case 1:
                                ref_lat = Encoding.ASCII.GetChars(prop.Value)[0];
                                break;
                            //Latitude
                            case 2:
                                float deg_lat = BitConverter.ToInt32(prop.Value, 0) / BitConverter.ToInt32(prop.Value, 4);
                                float min_lat = BitConverter.ToInt32(prop.Value, 8) / BitConverter.ToInt32(prop.Value, 12);
                                double sec_lat = BitConverter.ToInt32(prop.Value, 16) / BitConverter.ToInt32(prop.Value, 20); ;
                                string Lat = deg_lat.ToString() + "° " + min_lat.ToString() + "\' " + sec_lat.ToString() + "\"" + ref_lat;
                                fileData.Lat = Lat;
                                fileData.Lat_Float = deg_lat + (min_lat / 60) + (sec_lat / 3600);
                                fileData.Lat_Float = (ref_lat == 'S' ? fileData.Lat_Float * -1 : fileData.Lat_Float);
                                break;
                            //Longitude Direction
                            case 3:
                                ref_long = Encoding.ASCII.GetChars(prop.Value)[0];
                                break;
                            //Longitude
                            case 4:
                                float deg_long = BitConverter.ToInt32(prop.Value, 0) / BitConverter.ToInt32(prop.Value, 4);
                                float min_long = BitConverter.ToInt32(prop.Value, 8) / BitConverter.ToInt32(prop.Value, 12);
                                double sec_long = BitConverter.ToInt32(prop.Value, 16) / BitConverter.ToInt32(prop.Value, 20); ;
                                string Long = deg_long.ToString() + "° " + min_long.ToString() + "\' " + sec_long.ToString() + "\"" + ref_long;
                                fileData.Long = Long;
                                fileData.Long_Float = deg_long + (min_long / 60) + (sec_long / 3600);
                                fileData.Long_Float = (ref_long == 'W' ? fileData.Long_Float * -1 : fileData.Long_Float);
                                break;
                            //Altitude (acima ou abaixo do nível do mar)
                            //case 5:
                            //    if (prop.Value[0] == 1)
                                    //Abaixo do Nível do Mar
                            //    break;
                            //Altitude
                            case 6:
                                float alt = BitConverter.ToInt32(prop.Value, 0) / BitConverter.ToInt32(prop.Value, 4);
                                fileData.Altitude = alt.ToString();
                                break;
                            //Positioning Method
                            case 27:
                                fileData.GPSProcessingMethod = Encoding.ASCII.GetString(prop.Value);
                                fileData.GPSProcessingMethod = fileData.GPSProcessingMethod.Substring(1, fileData.GPSProcessingMethod.Length - 1); //remove o '\0' no final da String
                                break;
                        }
                    }


                    bool LocalFound = fileData.Lat != null;

                    //Inserir nova linha no DataGridView
                    DataGridViewCellStyle LocalFoundCellStyle = new DataGridViewCellStyle();
                    

                    DataGridViewRow row = new DataGridViewRow();
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = fileData.Filename });

                    string LocalFoundString = "";
                    if (LocalFound)
                    {
                        LocalFoundCellStyle.ForeColor = Color.Blue;
                        LocalFoundString = "SIM";
                    }
                    else
                    {
                        LocalFoundCellStyle.ForeColor = Color.Red;
                        LocalFoundString = "NÃO";
                    }

                    row.Cells.Add(new DataGridViewTextBoxCell { Value = LocalFoundString, Style = LocalFoundCellStyle });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = (fileData.Lat_Float == 0 ? "" : fileData.Lat_Float.ToString().Replace(",", ".")) });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = (fileData.Long_Float == 0 ? "" : fileData.Long_Float.ToString().Replace(",", ".")) });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = fileData.Altitude });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = fileData.GPSProcessingMethod });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = fileData.DateTimeOriginal });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = fileData.Make });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = fileData.Model });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = fileData.Filepath });

                    DataGridView.Rows.Add(row);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DataGridView.Rows.Clear();
        }

        private void btnKML_Click(object sender, EventArgs e)
        {
            string KML_header = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n<kml xmlns=\"http://www.opengis.net/kml/2.2\" xmlns:gx=\"http://www.google.com/kml/ext/2.2\" xmlns:kml=\"http://www.opengis.net/kml/2.2\" xmlns:atom=\"http://www.w3.org/2005/Atom\">\n<Document>\n\t<name>Metadados_IMG.kml</name>\n\t<StyleMap id=\"m_ylw-pushpin\">\n\t\t<Pair>\n\t\t\t<key>normal</key>\n\t\t\t<styleUrl>#s_ylw-pushpin</styleUrl>\n\t\t</Pair>\n\t\t<Pair>\n\t\t\t<key>highlight</key>\n\t\t\t<styleUrl>#s_ylw-pushpin_hl</styleUrl>\n\t\t</Pair>\n\t</StyleMap>\n\t<Style id=\"s_ylw-pushpin\">\n\t\t<IconStyle>\n\t\t\t<scale>1.1</scale>\n\t\t\t<Icon>\n\t\t\t\t<href>http://maps.google.com/mapfiles/kml/pushpin/ylw-pushpin.png</href>\n\t\t\t</Icon>\n\t\t\t<hotSpot x=\"20\" y=\"2\" xunits=\"pixels\" yunits=\"pixels\"/>\n\t\t</IconStyle>\n\t</Style>\n\t<Style id=\"s_ylw-pushpin_hl\">\n\t\t<IconStyle>\n\t\t\t<scale>1.3</scale>\n\t\t\t<Icon>\n\t\t\t\t<href>http://maps.google.com/mapfiles/kml/pushpin/ylw-pushpin.png</href>\n\t\t\t</Icon>\n\t\t\t<hotSpot x=\"20\" y=\"2\" xunits=\"pixels\" yunits=\"pixels\"/>\n\t\t</IconStyle>\n\t</Style>\n\t<Folder>\n\t\t<name>Metadados_IMG</name>\n\t\t<open>1</open>";
            string KML_point = "\n\t\t<Placemark>\n\t\t\t<name>[FILENAME]</name>\n\t\t\t<description>[DATETIMEORIGINAL]\n[MAKE]\n[MODEL]\n[PROCESSINGMETHOD]</description>\n\t\t\t<LookAt>\n\t\t\t\t<longitude>[LONG]</longitude>\n\t\t\t\t<latitude>[LAT]</latitude>\n\t\t\t\t<altitude>[ALTITUDE]</altitude>\n\t\t\t\t<heading>0</heading>\n\t\t\t\t<tilt>0</tilt>\n\t\t\t\t<range>1000</range>\n\t\t\t\t<gx:altitudeMode>relativeToFloor</gx:altitudeMode>\n\t\t\t</LookAt>\n\t\t\t<styleUrl>#m_ylw-pushpin</styleUrl>\n\t\t\t<Point>\n\t\t\t\t<gx:drawOrder>1</gx:drawOrder>\n\t\t\t\t<coordinates>[LONG],[LAT],[ALTITUDE]</coordinates>\n\t\t\t</Point>\n\t\t</Placemark>\n";
            string KML_footer = "\t\t<atom:link rel=\"app\" href=\"https://www.google.com/earth/about/versions/#earth-pro\" title=\"Google Earth Pro 7.3.6.10201\"></atom:link>\n\t</Folder>\n</Document>\n</kml>";

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Arquivo KML|*.kml";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(new FileStream(dialog.FileName, FileMode.Create))){
                    sw.Write(KML_header);

                    foreach(DataGridViewRow row in DataGridView.Rows)
                    {
                        if (row.Cells[1].Value.ToString().Equals("SIM"))
                        {
                            string StringPoint = KML_point.Replace("[FILENAME]", row.Cells[0].Value.ToString());
                            StringPoint = StringPoint.Replace("[DATETIMEORIGINAL]", row.Cells[6].Value.ToString());
                            StringPoint = StringPoint.Replace("[MAKE]", row.Cells[7].Value.ToString());
                            StringPoint = StringPoint.Replace("[MODEL]", row.Cells[8].Value.ToString());
                            StringPoint = StringPoint.Replace("[PROCESSINGMETHOD]", (row.Cells[5].Value != null ? row.Cells[5].Value.ToString() : ""));
                            StringPoint = StringPoint.Replace("[LAT]", row.Cells[2].Value.ToString());
                            StringPoint = StringPoint.Replace("[LONG]", row.Cells[3].Value.ToString());
                            StringPoint = StringPoint.Replace("[ALTITUDE]", row.Cells[4].Value.ToString());
                            sw.Write(StringPoint);
                        }
                    }

                    sw.Write(KML_footer);
                }

                Process.Start(dialog.FileName);
            }

        }
    }
}
