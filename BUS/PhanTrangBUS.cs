using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhanTrangBUS
    {
        public int current_page = 1;
        public int total_page = 1;
        public int total_record = 1;
        public int limit = 10;
        public int start = 0;
        public string link_full = "";
        public string link_first = "";
        public int range = 6;
        public int min = 0;
        public int max = 0;

        public PhanTrangBUS()
        {
            current_page = 1;
            total_page = 1;
            total_record = 1;
            limit = 10;
            start = 0;
            link_full = "";
            link_first = "";
            range = 6;
            min = 0;
            max = 0;
        }
        public void init()
        {
            if (limit < 0)
                limit = 0;

            total_page = total_record / limit;

            if (this.total_page < 0)
                this.total_page = 1;
            if (this.current_page < 1)
                this.current_page = 1;
            if (this.current_page > total_page)
                this.current_page = total_page;

            this.start = (this.current_page - 1) * this.limit;

            int middle = range / 2;
            if (total_page < range)
            {
                this.min = 1;
                this.max = total_page;
            }
            else
            {
                this.min = current_page - (middle +1);
                this.max = current_page + middle - 1;

                if(this.min < 1)
                {
                    this.min = 1;
                    this.max = range;
                }
                else if(this.max > this.total_page)
                {
                    this.max = total_page;
                    this.min = total_page - range + 1;
                }
            }


        }
        public string link(int page)
        {
            if(page <= 1 && !String.IsNullOrEmpty(link_first))
            {
                return this.link_first;
            }
            return link_full.Replace("{page}",Convert.ToString(page));
        }
        public string showHtml()
        {
            string p = "";
            if(this.total_record > this.limit)
            {
                p = "<div class='pagination'>";
                if(this.current_page > 1)
                {                     
                       p += "<a href='" + this.link(this.current_page-1) +"' class='prev-arrow'><i class='fa fa-long-arrow-left' aria-hidden='true'></i></a>";
                       
                }
                for(int i = this.min; i < this.max; i++)
                {
                    if(current_page == i)
                        p += "<a href ='" + "'class='active' >" + i +"</a>";
                    else
                        p += "<a href ='" + this.link(i) + "'>"+i+"</a>";

                }
                if(this.current_page < this.total_page)
                {
                    p += "<a href='#' class='dot-dot'><i class='fa fa-ellipsis-h' aria-hidden='true'></i></a>";                
                    p += "<a href ='" + this.link(this.total_page) + "'>" + this.total_page +"</a>";
                    p += "<a href = '" + this.link(this.current_page + 1) + "' class='next-arrow'><i class='fa fa-long-arrow-right' aria-hidden='true'></i></a>";
                }
                p += "</div>";

            }
            return p;
        }
    }
}
