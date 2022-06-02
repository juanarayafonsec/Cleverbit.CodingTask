namespace Cleverbit.CodingTask.Host.Mappings
{
    public class MappingProfile: Profile
        public MappingProfile()
        {
            CreateMap<Developer, DeveloperDTO>(); //Map from Developer Object to DeveloperDTO Object
        }
    }
}
