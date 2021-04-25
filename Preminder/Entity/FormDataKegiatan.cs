using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Preminder.Entity
{
    class FormDataKegiatan
    {
        [JsonProperty(Order = 0)]
        public List<String> finishedTasks { get; set; }
        [JsonProperty(Order = 1)]
        public List<String> toDoTasks { get; set; }

        public FormDataKegiatan(List<String> toDoTasks, List<String> finishedTasks)
        {
            this.toDoTasks = toDoTasks;
            this.finishedTasks = finishedTasks;
        }
    }
}
