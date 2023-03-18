namespace ui;

public class MainWindow : Adw.ApplicationWindow
{
    private MainWindow(Gtk.Builder builder, string name) : base(builder.GetPointer(name), false)
    {
        builder.Connect(this);

        // Do any initialization, or connect signals here.
    }


    public MainWindow(Adw.Application application) : this(new Gtk.Builder("MainWindow.ui"), "main_window")
    {
        this.Application = application;
    }
}
