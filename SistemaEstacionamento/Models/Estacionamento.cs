namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal initialPrice = 0;
        private decimal pricePerHour = 0;
        private List<string> vehicles = new List<string>();

        public decimal InitialPrice => this.initialPrice; 
        public decimal PricePerHour  => this.pricePerHour;
        public bool IsEmptyVehicle => !vehicles.Any();

        public Estacionamento(decimal initialPrice, decimal pricePerHour)
        {
            this.initialPrice = initialPrice;
            this.pricePerHour = pricePerHour;
        }

        public void AddVehicle(string vehiclePlate)
        {
            this.vehicles.Add(vehiclePlate);
        }

        public bool ContainVehiclePlate(string vehiclePlate)
        {
            return vehicles.Any(x => x.ToUpper() == vehiclePlate.ToUpper());
        }

        public void RemoveVehicle(string vehiclePlate)
        {
            vehicles.Remove(vehiclePlate);
        }

        public void ListVehicles()
        {
            foreach(var v in vehicles)
            {
               Console.WriteLine(v);
            }
        }
    }
}