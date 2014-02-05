using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1_3_konvertera_temperaturer
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // då konvertera knappen klickats
        protected void ConvertButton_Click(object sender, EventArgs e)
        {

            // och formuläret klarar valideringen
            if(IsValid){                

                // spara de värden som användaren matat in
                var convertFrom = int.Parse(startTempBox.Text);
                var endT = int.Parse(endTempBox.Text);
                var increaseT = int.Parse(increaseTempBox.Text);                

                // så länge som värdet som skall konverteras är lägre än sluttemperaturen
                while (convertFrom <= endT)
                {
                    // lägg till ny rad i tabellen
                    TableRow tRow = new TableRow();
                    Table1.Rows.Add(tRow);

                    // lägg till värdet som skall konverteras i första cellen
                    TableCell convertFromCell = new TableCell();
                    convertFromCell.Text = convertFrom.ToString();
                    tRow.Cells.Add(convertFromCell);

                    // och det konverterade värdet i andra cellen
                    TableCell convertToCell = new TableCell();

                    if (celsiusRadio.Checked == true) {
                        convertToCell.Text = Model.TemperatureConverter.CelsiusToFahrenheit(convertFrom).ToString();

                        // tabellrubriker
                        firstTemperatureHeader.Text = "Celsius";
                        secondTemperatureHeader.Text = "Fahrenheit";
                    }
                    else if(fahrenheitRadio.Checked == true){
                        convertToCell.Text = Model.TemperatureConverter.FahrenheitToCelsius(convertFrom).ToString();

                        // tabellrubriker
                        firstTemperatureHeader.Text = "Fahrenheit";
                        secondTemperatureHeader.Text = "Celsius";
                    }

                    tRow.Cells.Add(convertToCell);

                    // öka sedan på önskad konverterings temperatur med temperatursteg
                    convertFrom = convertFrom + increaseT;
                }
                
                // slutligen gör tabellen synlig
                Table1.Visible = true;
           
            }
        }
    }
}