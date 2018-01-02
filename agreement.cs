using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class agreement_struct
    {
        public int cmd;
      //  public int msg_mode;
      //  public int msg_source;
        public string param;
    }

    class ag_param_log
    {
        public int index;
        public string log_info;
    }
  
    //PC 到 串口
    class am_pctouart_cmd {


        public string getlog(int index)
        {
            String str =  string.Format(" {{\"cmd\":{0},\"param\":{{\"index\":{1}}} }}",0x10,index);
            
            return str;
        }

        public string get_gw_temperature()
        {
            String str = string.Format(" {{\"cmd\":{0} }}", 0x20);

            return str;
        }

        public string set_gw_dev_light_temperature(int off,int pro,int rec)
        {
            String str = string.Format(" {{\"cmd\":{0},\"param\":{{\"off\":{1},\"pro\":{2},\"rec\":{3} }} }}", 0x0021, off, pro, rec);

            return str;
        }

        public string get_gw_dev_light_temperature()
        {
            String str = string.Format(" {{\"cmd\":{0} }}", 0x0022);

            return str;
        }

        public string set_gw_dev_light_allpower(int power)
        {
            String str = string.Format(" {{\"cmd\":{0},\"param\":{{\"power\":{1}}} }}", 0x0023, power);

            return str;
        }

        public string set_gw_dev_light_power(uint id,int power)
        {
     

            String str = string.Format(" {{\"cmd\":{0},\"param\":{{\"power\":{1},\"id\":{2} }} }}", 0x0024, power,id);

            return str;
        }

        public string set_gw_dev_light_group(uint id, int group_id)
        {


            String str = string.Format(" {{\"cmd\":{0},\"param\":{{\"group_id\":{1},\"id\":{2} }} }}", 0x0025, group_id, id);

            return str;
        }

        public string set_gw_dev_light_name(uint id, string name)
        {
            String str = string.Format(" {{\"cmd\":{0},\"param\":{{\"name\":\"{1}\",\"id\":{2} }} }}", 0x0026, name,id);
            return str;
        }

        public string set_gw_dev_light_timer_validate(uint id, int year_on, int month_on, int day_on, int year_off, int month_off, int day_off)
        {
            String str = string.Format(" {{\"cmd\":{0},\"param\":{{\"year_o\":{1},\"mon_o\":{2},\"day_o\":{3},\"year_f\":{4},\"mon_f\":{5},\"day_f\":{6},\"id\":{2} }} }}", 0x0027,year_on,month_on,day_on,year_off,month_off,day_off, id);
            return str;
        }

        public string set_gw_dev_light_timer(uint id, int index, int h_o, int m_o, int h_f, int m_f, int enable, int power)
        {
            String str = string.Format(" {{\"cmd\":{0},\"param\":{{\"h_o\":{1},\"m_o\":{2},\"h_f\":{3},\"m_f\":{4},\"enable\":{5},\"power\":{6},\"id\":{7},\"index\":{8} }} }}", 0x0028, h_o, m_o, h_f, m_f, enable, power, id,index);
            return str;
        }

        public string get_gw_dev_light_num()
        {
            String str = string.Format(" {{\"cmd\":{0} }}", 0x0029);
            return str;
        }
        public string get_gw_dev_light_get_id(int id_flash_index)
        {
            String str = string.Format(" {{\"cmd\":{0},\"param\":{{\"id_flash_index\":{1}}} }}", 0x002a, id_flash_index);
            return str;
        }
        public string get_gw_dev_light_get_info(uint id)
        {
            String str = string.Format(" {{\"cmd\":{0},\"param\":{{\"light_id\":{1}}} }}", 0x002b, id);
            return str;
        }

        public string set_gw_dev_light_timer_mode_1(uint week)
        {
            String str = string.Format(" {{\"cmd\":{0},\"param\":{{\"timer_repeat_week\":{1}}} }}", 0x0030, week);
            return str;
        }
        public string set_gw_dev_light_timer_mode_2(int s_year, int s_mon, int s_day, int e_year, int e_mon, int e_day)
        {
            String str = string.Format(" {{\"cmd\":{0},\"param\":{{\"s_year\":{1},\"s_mon\":{2},\"s_day\":{3},\"e_year\":{4},\"e_mon\":{5},\"e_day\":{6} }} }}", 0x0031,  s_year,  s_mon,  s_day,  e_year,  e_mon,  e_day);
        //    String str = "{{ \"cmd\":49 }}";
            return str;
        }


        public string get_gw_dev_light_timer_mode()
        {
            String str = string.Format(" {{\"cmd\":{0}}}", 0x0032);
            return str;
        }
        public string get_gw_dev_light_timer_mode1_week()
        {
            String str = string.Format(" {{\"cmd\":{0}}}", 0x0033);
            return str;
        }


        public string set_gw_dev_light_all_timer(uint id, int index, int h_o, int m_o, int h_f, int m_f, int enable, int power)
        {
            String str = string.Format(" {{\"cmd\":{0},\"param\":{{\"h_o\":{1},\"m_o\":{2},\"h_f\":{3},\"m_f\":{4},\"enable\":{5},\"power\":{6},\"id\":{7},\"index\":{8} }} }}", 0x0034, h_o, m_o, h_f, m_f, enable, power, id, index);
            return str;
        }
        public string get_gw_dev_light_all_timer()
        {
            String str = string.Format(" {{\"cmd\":{0} }}", 0x0035);
            return str;
        }

        public string set_gw_dev_light_all_tied(int time,int enable)
        {
            String str = string.Format(" {{\"cmd\":{0},\"param\":{{\"time\":{1},\"enable\":{2}}} }}", 0x0036, time,enable);
            return str;
        }

        public string get_gw_dev_light_all_tied()
        {
            String str = string.Format(" {{\"cmd\":{0} }}", 0x0037);
            return str;
        }

        public string get_gw_dev_light_version(uint id)
        {
            String str = string.Format(" {{\"cmd\":{0},\"param\":{{\"light_id\":{1}}} }}", 0x0038, id);
            return str;
        }


        public string get_gw_dev_light_get_log(uint id)
        {
            String str = string.Format(" {{\"cmd\":{0},\"param\":{{\"light_id\":{1}}} }}", 0x0040, id);
            return str;
        }

        public string gw_dev_light_set_deviceID(uint id)
        {
            String str = string.Format(" {{\"cmd\":{0},\"param\":{{\"light_id\":{1}}} }}", 0x0041, id);
            return str;
        }

        public string gw_dev_light_get_deviceID()
        {
            String str = string.Format(" {{\"cmd\":{0} }}", 0x0042);
            return str;
        }

        public string gw_dev_light_add_device()
        {
            String str = string.Format(" {{\"cmd\":{0} }}", 0x0043);
            return str;
        }

        public string get_gw_dev_light_clear_log(uint id)
        {
            String str = string.Format(" {{\"cmd\":{0},\"param\":{{\"light_id\":{1}}} }}", 0x0044, id);
            return str;
        }
        public string gw_dev_light_reset_device()
        {
            String str = string.Format(" {{\"cmd\":{0} }}", 0x0045);
            return str;
        }
        public string gw_get_time()
        {
            String str = string.Format(" {{\"cmd\":{0} }}", 0x0046);
            return str;
        }
        public string gw_set_time(int year,int mon,int day,int week,int hour,int min,int sec)
        {
            String str = string.Format(" {{\"cmd\":{0},\"param\":{{\"year\":{1},\"mon\":{2},\"day\":{3},\"week\":{4},\"hour\":{5},\"min\":{6},\"sec\":{7} }} }}", 0x0047, year, mon, day, week, hour, min, sec);
            return str;
        }

}
}