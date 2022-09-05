using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenApiEditor.ViewModels.Main
{
    public enum MainSidebarItemType
    {
        Info,
        Schema,
        Path
    }

    /// <summary>
    /// Item du menu principal
    /// </summary>
    public class MainSidebarItemModel
    {
        public string Name { get; set; }

        public string ID { get; set; }

        public MainSidebarItemType Type { get; set; }


        public MainSidebarItemModel(string name, string id, MainSidebarItemType type)
        {
            this.Name = name;
            this.ID = id;
            this.Type = type;

        }
    }
}
