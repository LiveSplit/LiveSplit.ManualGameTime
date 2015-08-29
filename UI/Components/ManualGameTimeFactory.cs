using LiveSplit.Delta;
using LiveSplit.Model;
using LiveSplit.UI.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: ComponentFactory(typeof(ManualGameTimeFactory))]

namespace LiveSplit.Delta
{
    public class ManualGameTimeFactory : IComponentFactory
    {
        public string ComponentName
        {
            get { return "Manual Game Time"; }
        }

        public string Description
        {
            get { return "Allows manually entering segment times as game time."; }
        }

        public ComponentCategory Category
        {
            get { return ComponentCategory.Control; }
        }

        public IComponent Create(LiveSplitState state)
        {
            return new ManualGameTimeComponent(state);
        }

        public string UpdateName
        {
            get { return ComponentName; }
        }

        public string XMLURL
        {
#if RELEASE_CANDIDATE
            get { return "http://livesplit.org/update_rc_sdhjdop/Components/update.LiveSplit.ManualGameTime.xml"; }
#else
            get { return "http://livesplit.org/update/Components/update.LiveSplit.ManualGameTime.xml"; }
#endif
        }

        public string UpdateURL
        {
#if RELEASE_CANDIDATE
            get { return "http://livesplit.org/update_rc_sdhjdop/"; }
#else
            get { return "http://livesplit.org/update/"; }
#endif
        }

        public Version Version
        {
            get { return Version.Parse("1.6"); }
        }
    }
}
