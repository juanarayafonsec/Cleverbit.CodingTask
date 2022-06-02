using System.Collections.Generic;

namespace Cleverbit.CodingTask.Host.DTOs
{
    public class UserGameesDto
    {
        public string GameName { get; set; }
        public IEnumerable<string> Winners { get; set; }
    }
}
