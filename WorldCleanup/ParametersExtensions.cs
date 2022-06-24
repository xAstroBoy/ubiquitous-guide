
using UnityEngine;
using VRC.Playables;

namespace WorldCleanup
{

    public static class Extensions
    {
        internal static AvatarParameter.ParameterType Get_ParameterType(this AvatarParameter param)
        {
            return param.field_Public_ParameterType_0;
        }


    }

}
