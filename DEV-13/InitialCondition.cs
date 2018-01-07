namespace DEV_13
{
    public struct InitialCondition
    {
        public int cash { get; set; }
        public int productivity { get; set; }
        public IStrategy criterion { get; set; }
    }
}
