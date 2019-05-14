/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package sorting_visualizer;
import java.awt.Canvas;
import java.awt.Graphics;
import java.awt.Color;
import javax.swing.JFrame;

/**
 *
 * @author Alex
 */
public class Drawing extends Canvas {
    
    static JFrame frame = new JFrame("Sorting Visualizer");
    static Canvas canvas = new Drawing();
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        CreateCanvas();
    }

    //Main method to draw the graphics
    public void paint(Graphics gfx){
        gfx.setColor(Color.white);
        //gfx.fillRect(0, 0, this.getSize().width / 2, this.getSize().height / 2);        
    }
    
    public static void CreateCanvas(){
        canvas.setSize(800, 600);
        canvas.setBackground(Color.BLACK);
        frame.add(canvas);
        frame.pack();
        frame.setVisible(true);
    }
}
