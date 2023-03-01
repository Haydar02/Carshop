namespace Carshop.Models
{
    public class Car
    {
        public int Id { get; set; }

        public string? Model { get; set; }

        public double Price { get; set; }

        public string? LicensPlat { get; set; }


        public void ModelValidat()
        {
            if (Model == null)
            {
                throw new ArgumentNullException("Model dose not be null");
            }

            if (Model.Length != 3)
            {
                throw new ArgumentException();
            }
        }

        public void PriceValdiate()
        {
            if (Price <= 0)
            {
                throw new ArgumentOutOfRangeException("");
            }

        }
        public void LicensePlatvalidate()

        {
            if (LicensPlat == null)
            {
                throw new ArgumentNullException();
            }

            if (LicensPlat.Length <= 1)
            {
                throw new ArgumentException();
            }
            if (LicensPlat.Length != 8)
            {
                throw new ArgumentException();
            }
        }


    }
}