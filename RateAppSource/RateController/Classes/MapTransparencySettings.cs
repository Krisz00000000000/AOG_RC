namespace RateController.Classes
{
    public static class MapTransparencySettings
    {
        public const byte DefaultTransparency = 150;

        public static byte ZoneTransparency
        {
            get
            {
                return byte.TryParse(Props.GetAppProp("MapZoneTransparency"), out byte value)
                    ? value
                    : DefaultTransparency;
            }
            set
            {
                Props.SetAppProp("MapZoneTransparency", System.Math.Min(255, value).ToString());
            }
        }

        public static byte TargetZoneTransparency
        {
            get
            {
                return byte.TryParse(Props.GetAppProp("MapTargetZoneTransparency"), out byte value)
                    ? value
                    : DefaultTransparency;
            }
            set
            {
                Props.SetAppProp("MapTargetZoneTransparency", System.Math.Min(255, value).ToString());
            }
        }
    }
}
