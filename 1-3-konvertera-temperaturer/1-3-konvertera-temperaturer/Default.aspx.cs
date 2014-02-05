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

        protected void ConvertButton_Click(object sender, EventArgs e)
        {
            // då konvertera knappen klickats
            if(IsValid){
                // och formuläret klarar valideringen

                // spara de värden som användaren matat in
                var convertFrom = int.Parse(startTempBox.Text);
                var endT = int.Parse(endTempBox.Text);
                var increaseT = int.Parse(increaseTempBox.Text);                
                int convertTo;

                // om användaren valt celsius till fahrenheit
                if(celsiusRadio.Checked == true){

                    // tabellrubriker
                    firstTemperatureHeader.Text = "Celsius";
                    secondTemperatureHeader.Text = "Fahrenheit";

                    // så länge som värdet som skall konverteras är lägre än sluttemperaturen
                    while (convertFrom <= endT)
                    {
                        // anropa Celsius till Fahrenheit metoden och 
                        convertTo = Model.TemperatureConverter.CelsiusToFahrenheit(convertFrom);

                        // lägg till ny rad i tabellen
                        TableRow tRow = new TableRow();
                        Table1.Rows.Add(tRow);

                        // lägg till celsius värdet i första cellen
                        TableCell convertFromCell = new TableCell();
                        convertFromCell.Text = convertFrom.ToString();
                        tRow.Cells.Add(convertFromCell);

                        // och fahrenheit värdet i andra cellen
                        TableCell convertToCell = new TableCell();
                        convertToCell.Text = convertTo.ToString();
                        tRow.Cells.Add(convertToCell);

                        // öka sedan på önskad konverterings temperatur med temperatursteg
                        convertFrom = convertFrom + increaseT;
                    }
                }

                // om användaren valt fahrenheit till celsius
                else if (fahrenheitRadio.Checked == true)
                {
                    // tabellrubriker
                    firstTemperatureHeader.Text = "Fahrenheit";
                    secondTemperatureHeader.Text = "Celsius";

                    // så länge som värdet som skall konverteras är lägre än sluttemperaturen
                    while (convertFrom <= endT)
                    {
                        // anropa Fahrenheit till Celsius metoden och
                        convertTo = Model.TemperatureConverter.FahrenheitToCelsius(convertFrom);                        

                        // lägg till ny rad i tabellen
                        TableRow tRow = new TableRow();
                        Table1.Rows.Add(tRow);

                        // lägg till fahrenheit värdet i första cellen
                        TableCell convertFromCell = new TableCell();
                        convertFromCell.Text = convertFrom.ToString();
                        tRow.Cells.Add(convertFromCell);

                        // och celsius värdet i andra cellen
                        TableCell convertToCell = new TableCell();
                        convertToCell.Text = convertTo.ToString();
                        tRow.Cells.Add(convertToCell);

                        // öka sedan på önskad konverterings temperatur med temperatursteg
                        convertFrom = convertFrom + increaseT;
                    }

                }

                // slutligen gör tabellen synlig
                Table1.Visible = true;
           
            }
        }
    }
}