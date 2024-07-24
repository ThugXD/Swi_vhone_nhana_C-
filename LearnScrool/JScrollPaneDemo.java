import java.awt.*;
import javax.swing.*;

class JScrollPaneDemo extends JApplet
{
    Container c;
    JPanel panel;
    public void init()
    {
        c = getContentPane();
        c.setLayout(new BorderLayout());

        panel = new JPanel();
        panel.setLayout(new GridLayout(20, 20));

        int b = 1;
        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                panel.add(new JButton("Button" + b));
                b++;
            }
        }

        int v = ScrollPaneConstants.VERTICAL_SCROLLBAR_AS_NEEDED;
        int h = ScrollPaneConstants.HORIZONTAL_SCROLLBAR_AS_NEEDED;

        JScrollPane jsp = new JScrollPane(panel, v, h);
        c.add(jsp, "Center");
    }
}

/*
<applet code = "JScrollPaneDemo" width = "250" height = "250">
</applet>
*/