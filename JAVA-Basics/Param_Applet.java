import java.applet.Applet;
import java.awt.*;

/*	<applet code = "Param_Applet" width = "250" height = "200"> 
		<param name = "site" value = "www.techmeservices.unaux.com"> </param>
	</applet>	
*/

public class Param_Applet extends Applet
{
	private String message = "Unable to load site";
	public void paint(Graphics g)
	{
		String Site = getParameter("site");
		if(Site == null)
			Site = message;
		g.drawString(Site, 30, 100);
	}
}
