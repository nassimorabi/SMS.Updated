namespace SMS.App.Views.IViews
{
    public interface IProgramView
    {
        string Description { get; set; }
        int ProgramId { get; set; }
        string ProgramName { get; set; }
        event EventHandler CreateEvent;
        event EventHandler ReadEvent;
        event EventHandler UpdateEvent;
        event EventHandler DeleteEvent;

        void GetProgramList(BindingSource bindingSource);
    }
}