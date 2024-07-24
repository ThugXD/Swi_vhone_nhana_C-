import java.awt.event.*;
import java.awt.*;
import javax.swing.*;

public class JColorChooserDemo extends JFrame implements ActionListener
{
    JButton b;
    Container c;

    JColorChooserDemo()
    {
        c = getContentPane();
        c.setLayout(new FlowLayout());

        b = new JButton("Color Chooser");
        b.addActionListener(this);

        c.add(b);
    }

    public void actionPerformed(ActionEvent e)
    {
        Color initialcolor = Color.RED;
        Color color = JColorChooser.showDialog(this, "Select a color", initialcolor);
        c.setBackground(color);
    }

    public static void main(String[] args)
    {
        JColorChooserDemo jColorChooser = new JColorChooserDemo();
        jColorChooser.setSize(400, 400);
        jColorChooser.setVisible(true);
        jColorChooser.setDefaultCloseOperation(EXIT_ON_CLOSE);
    }
}  