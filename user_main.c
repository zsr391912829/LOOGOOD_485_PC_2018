#include "mylib.h"
#include "XXXX.h"




void main()
{
	am_pctouart_cmd am_pctouart_cmd_ = new am_pctouart_cmd();
	byte[] byteArray = System.Text.Encoding.ASCII.GetBytes(am_pctouart_cmd_.set_gw_dev_light_temperature(bar_off.Value, bar_dec.Value, bar_rec.Value));
	mycomm.WritePort(byteArray, 0, byteArray.Length);	
}
