namespace ClassAdapter
{
    public class CityFromExternalSystem
    {
        public string Name { get; private set; }
        public string NickName { get; private set; }
        public int Inhabitants { get; private set; }

        public CityFromExternalSystem(string name, string nickName, int inhabitants)
        {
            Name = name;
            NickName = nickName;
            Inhabitants = inhabitants;
        }
    }

    //Adaptee
    public class ExternalSystem
    {
        public CityFromExternalSystem GetCity()
        {
            return new CityFromExternalSystem("Baku", "Wind City", 4000000);
        }
    }

    public class City
    {
        public string FullName { get; private set; }
        public long Inhabitants { get; private set; }

        public City(string fullName, long inhabitants)
        {
            FullName = fullName;
            Inhabitants = inhabitants;
        }
    }

    //Target
    public interface ICityAdapter
    {
        City GetCity();
    }

    //Adapter
    public class CityAdapter : ExternalSystem, ICityAdapter
    {


        public City GetCity()
        {
            var cityFromExternalSystem = base.GetCity();

            return new City($"{cityFromExternalSystem.Name} - {cityFromExternalSystem.NickName}", cityFromExternalSystem.Inhabitants);
        }
    }
}
