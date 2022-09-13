using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMVC.Enums
{
    public enum ModerationType
    {
        [Description("minor safety: if a minor is giving personal info, or if someone is posting about minors doing illegal/violent/sexual acts")]
        MinorSafety,
        [Description("propaganda")]
        Political,
        [Description("in context only, no word is banned. ex: 'that shit is funny!' is OK, while 'eat shit, dude!' is not")]
        Language,
        [Description("promoting/glorifying drug use")]
        Drugs,
        [Description("any statement of threat toward any entity")]
        Threatening,
        [Description("any graphic or suggestive sexual content")]
        Sexual,
        [Description("insults to an ethnicity or a 'call to arms' against an ethnic group")]
        HateSpeech,
        [Description("'doxing' or public humiliation of a non-public figure")]
        Shaming        
    }
}
