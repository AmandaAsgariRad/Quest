namespace Quest
{
    public class Hat
    {
        public int ShininessLevel { get; set; }

        public string ShininessDescription
        {
            get
            {
                if (ShininessLevel > 9)
                {
                    return "blinding";
                }
                else if (ShininessLevel >= 6 && ShininessLevel < 9)
                {
                    return "bright";
                }
                else if (ShininessLevel >= 2 && ShininessLevel < 5)
                {
                    return "noticeable";
                }
                else
                {
                    return "dull";
                }
            }
        }
    }
}