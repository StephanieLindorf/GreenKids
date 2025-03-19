using System.Data;
namespace GreenKids
{
    class Program
    {
        public static List<int> alleId = []; //oprettelse af liste for tøjId
        public static List<int> alleToejStoerrelse = []; //oprettelse af liste for tøjstørrelse
        public static List<string> alleTyper = []; //oprettelse af lister for tøjtype
        public static List<string> alleToejMaerke = []; //oprettelse af liste for tøjmærke
        public static List<int> alleToejStand = []; //oprettelse af lister for tøjstand
        public static List<string> alleToejMaterialer = []; //oprettelse af lister for tøjmateriale
        public static List<double> alleToejCO2Besparelse = []; //oprettelse af lister for CO2 besparelse
        public static List<bool> toejErSolgt = []; //oprettelse af lister for solgte varer
        public static List<DateTime> alleToejIndleveringsDate = []; //oprettelse af lister for indleveringsdato

        private static void Main(string[] args)
        {

            #region Variabler
            int toejId1 = 53764;
            string toejType1 = "Bukser";
            int toejStoerrelse1 = 36;
            string toejMaerke1 = "Levis";
            int toejStand1 = 1; //0 = God, 1 = Middel, 2 = Slidt
            string toejMateriale1 = "Bomuld";
            double toejCO2Besparelse1 = 7.1;
            bool toejErSolgt1 = false;
            DateTime toejIndleveringsDate1 = DateTime.Now;
            Console.WriteLine
                (toejId1 + " " + toejType1 + " " +
                toejStoerrelse1 + " " + toejMaerke1 + " " +
                toejStand1 + " " + toejMateriale1 + " " +
                toejCO2Besparelse1 + " " + toejErSolgt1 + " " + toejIndleveringsDate1);


            int toejId2 = 53765;
            string toejType2 = "Sko";
            int toejStoerrelse2 = 38;
            string toejMaerke2 = "Adidas";
            int toejStand2 = 0; //0 = God, 1 = Middel, 2 = Slidt
            string toejMateriale2 = "Laeder";
            double toejCO2Besparelse2 = 13.8;
            bool toejErSolgt2 = false;
            DateTime toejIndleveringsDate2 = DateTime.Now;
            Console.WriteLine
                (toejId2 + " " + toejType2 + " " +
                toejStoerrelse2 + " " + toejMaerke2 + " " +
                toejStand2 + " " + toejMateriale2 + " " +
                toejCO2Besparelse2 + " " + toejErSolgt2 + " " + toejIndleveringsDate2);


            int toejId3 = 53766;
            string toejType3 = "Tshirt";
            int toejStoerrelse3 = 40;
            string toejMaerke3 = "Gucci";
            int toejStand3 = 1; //0 = God, 1 = Middel, 2 = Slidt
            string toejMateriale3 = "Bomuld";
            double toejCO2Besparelse3 = 2.1;
            bool toejErSolgt3 = false;
            DateTime toejIndleveringsDate3 = DateTime.Now;
            Console.WriteLine
                (toejId3 + " " + toejType3 + " " +
                toejStoerrelse3 + " " + toejMaerke3 + " " +
                toejStand3 + " " + toejMateriale3 + " " +
                toejCO2Besparelse3 + " " + toejErSolgt3 + " " + toejIndleveringsDate3);
            #endregion

            string[] toejTyper = ["Bukser", "Sko", "Bluse", "Hoodie", "T-shirt", "Skjorte"]; //Oprettelse af array


            foreach (string toejType in toejTyper)
            {
                Console.WriteLine(toejType);

            }
            #region Tilføjelse af tøj
            alleId.Add(toejId1);
            alleId.Add(toejId2);
            alleId.Add(toejId3);

            alleTyper.Add(toejType1);
            alleTyper.Add(toejType2);
            alleTyper.Add(toejType3);

            alleToejStoerrelse.Add(toejStoerrelse1);
            alleToejStoerrelse.Add(toejStoerrelse2);
            alleToejStoerrelse.Add(toejStoerrelse3);

            alleToejMaerke.Add(toejMaerke1);
            alleToejMaerke.Add(toejMaerke2);
            alleToejMaerke.Add(toejMaerke3);

            alleToejStand.Add(toejStand1);
            alleToejStand.Add(toejStand2);
            alleToejStand.Add(toejStand3);

            alleToejMaterialer.Add(toejMateriale1);
            alleToejMaterialer.Add(toejMateriale2);
            alleToejMaterialer.Add(toejMateriale3);

            alleToejCO2Besparelse.Add(toejCO2Besparelse1);
            alleToejCO2Besparelse.Add(toejCO2Besparelse2);
            alleToejCO2Besparelse.Add(toejCO2Besparelse3);

            toejErSolgt.Add(toejErSolgt1);
            toejErSolgt.Add(toejErSolgt2);
            toejErSolgt.Add(toejErSolgt3);

            alleToejIndleveringsDate.Add(toejIndleveringsDate1);
            alleToejIndleveringsDate.Add(toejIndleveringsDate2);
            alleToejIndleveringsDate.Add(toejIndleveringsDate3);
            #endregion


            #region Loop
            foreach (int Id in alleId)
            {
                Console.WriteLine(Id);

            }


            foreach (string type in alleTyper)
            {
                Console.WriteLine(type);
            }
            foreach (int toejStoerrelse in alleToejStoerrelse)
            {
                Console.WriteLine(toejStoerrelse);

            }

            foreach (string toejMaerke in alleToejMaerke)
            {
                Console.WriteLine(toejMaerke);

            }


            foreach (int toejStand in alleToejStand)
            {
                Console.WriteLine(toejStand);
            }



            foreach (string toejMateriale in alleToejMaterialer)
            {
                Console.WriteLine(toejMateriale);
            }

            foreach (double toejC02Bespreale in alleToejCO2Besparelse)
            {
                Console.WriteLine(toejC02Bespreale);
            }


            foreach (bool solgt in toejErSolgt)

            {
                if (solgt == true)
                {
                    Console.WriteLine("Tøj blev solgt:");
                }
                else
                {
                    Console.WriteLine("Tøj er ikke solgt");
                }

            }
            foreach (DateTime toejIndleveringsDate in alleToejIndleveringsDate)
            {
                Console.WriteLine(toejIndleveringsDate);
            }
            #endregion


            Dictionary<string, double> dict = new Dictionary<string, double>();

            dict.Add("Bomuld Bukser", 7.1);
            dict.Add("Læder Sko", 13.8);
            dict.Add("Bomuld T-shirt", 2.1);

            foreach (KeyValuePair<string, double> ele in dict)
            {
                Console.WriteLine("Materiale: {0}, CO2 Besparelse: {1}", ele.Key, ele.Value);
            }

        }



        static void TilfoejToejstykke(int id, string type, int stoerrelse, string mærke, int stand,
            string materiale, double co2Besparelse, bool erSolgt, DateTime indleveringsDato)
        {
            alleId.Add(id);
            alleTyper.Add(type);
            alleToejStoerrelse.Add(stoerrelse);
            alleToejMaerke.Add(mærke);
            alleToejStand.Add(stand);
            alleToejMaterialer.Add(materiale);
            alleToejCO2Besparelse.Add(co2Besparelse);
            toejErSolgt.Add(erSolgt);
            alleToejIndleveringsDate.Add(indleveringsDato);
        }
    }
}








