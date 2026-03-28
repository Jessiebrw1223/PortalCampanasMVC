namespace PortalCampanasMVC.Models;

public class ResumenCampanasViewModel
{
    public int TotalCampanas { get; set; }
    public int CampanasVigentes { get; set; }
    public int CampanasProximas { get; set; }
    public decimal PromedioDescuento { get; set; }
    public int CantidadWeb { get; set; }
    public int CantidadApp { get; set; }
    public int CantidadTienda { get; set; }
}
