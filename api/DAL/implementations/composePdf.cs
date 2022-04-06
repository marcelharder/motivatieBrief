using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using api.DAL.code;
using api.DAL.Interfaces;
using api.DAL.models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

namespace api.DAL.implementations
{
    public class composePdf : IComposeBrief
    {
        private readonly IWebHostEnvironment _env;
        private readonly SpecialMaps _rm;
        private dataContext _context;
         public composePdf(IWebHostEnvironment env, SpecialMaps rm, dataContext context)
        {
            _env = env;
            _rm = rm;
            _context = context;
           
        }
        iTextSharp.text.Font smallfont = FontFactory.GetFont("Arial", 8);
        iTextSharp.text.Font boldfont = FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLD);
        iTextSharp.text.Font bigboldfont = FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD);
        CmykColor header_background_color = new CmykColor(0, 0, 70, 0);
        CmykColor footer_background_color = new CmykColor(0, 0, 0, 14);
        PdfPCell cell;

        public int deletePDF(int id)
        {
            var id_string = id.ToString();
            var pathToFile = _env.ContentRootPath + "/assets/pdf/";
            var file_name = pathToFile + id_string + ".pdf";

            if (System.IO.File.Exists(file_name))
            {
                System.IO.File.Delete(file_name);
                System.Threading.Thread.Sleep(20);
            }
            return 1;
        }

        public async Task composeAsync(int id)
        {
             Brief _br = await _context.Briefs.FirstOrDefaultAsync(r => r.Id == id);
                         
            
            var pathToFile = _env.ContentRootPath + "/assets/pdf/";
            var ps = id.ToString();
            var file_name = pathToFile + ps + ".pdf";

            using (var fs = new FileStream(file_name, FileMode.Create))
            {
                var doc = new iTextSharp.text.Document();
                iTextSharp.text.pdf.PdfWriter writer = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, fs);
                doc.SetMargins(0.0F, 10.0F, 70.0F, 10.0F);
                compose_pdf(doc, writer, _br);
            }
        }
        private int compose_pdf(iTextSharp.text.Document doc, iTextSharp.text.pdf.PdfWriter wri, Brief br)
        {
             doc.Open();
                    doc.Add(getHeader(br));
                    doc.Add(getBody(br));
                    doc.Add(getFooter(br));
                    PdfContentByte cb = wri.DirectContent;
                    cb.SetLineWidth(2.0F);
                    cb.SetGrayStroke(0.75F);
                    cb.MoveTo(40, 575);
                    cb.LineTo(540, 575);
                    cb.Stroke();
                    doc.Close();
                    return 1;
        }


        private PdfPTable getHeader(Brief br)
        {

            iTextSharp.text.Image i = iTextSharp.text.Image.GetInstance(br.PhotoUrl);
            i.ScaleToFit(85.0F, 100.0F);
            var header = new PdfPTable(2);
            header.TotalWidth = 500.0F;
            header.LockedWidth = true;

            var my_picture = new PdfPCell(i);
            my_picture.BackgroundColor = header_background_color;

            var cell_2 = new PdfPCell(getHeaderTable_1(br));
            cell_2.BackgroundColor = header_background_color;

            header.AddCell(my_picture);
            header.AddCell(cell_2);
           
            return header;
        }

         private PdfPTable getHeaderTable_1(Brief br)
        {
            var help = new PdfPTable(1);

            var cell_1 = new PdfPCell(new Paragraph(br.line_1, smallfont)); cell_1.Border = 0; cell_1.HorizontalAlignment = 1;
            var cell_2 = new PdfPCell(new Paragraph(br.line_2, smallfont)); cell_2.Border = 0; cell_2.HorizontalAlignment = 1;
            var cell_3 = new PdfPCell(new Paragraph(br.line_3, smallfont)); cell_3.Border = 0; cell_3.HorizontalAlignment = 1;
            var cell_4 = new PdfPCell(new Paragraph(br.line_4, smallfont)); cell_4.Border = 0; cell_4.HorizontalAlignment = 1;


            help.AddCell(cell_1);
            help.AddCell(cell_2);
            help.AddCell(cell_3);
            help.AddCell(cell_4);
            return help;
        }

          private PdfPTable getBody(Brief br)
        {

            var gen_details = new PdfPTable(1);
            gen_details.TotalWidth = 500.0F;
            gen_details.LockedWidth = true;


            cell = new PdfPCell(new Paragraph(br.line_5, bigboldfont));
            cell.Border = 0;
            cell.HorizontalAlignment = 0;
            cell.PaddingBottom = 10.0F;
            gen_details.AddCell(cell);


            cell = new PdfPCell(new Paragraph(br.line_6, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
            cell = new PdfPCell(new Paragraph(br.line_7, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
            cell = new PdfPCell(new Paragraph(br.line_8, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
            cell = new PdfPCell(new Paragraph(br.line_9, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
           
            cell = new PdfPCell(new Paragraph(br.line_10, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
            cell = new PdfPCell(new Paragraph(br.line_11, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
            cell = new PdfPCell(new Paragraph(br.line_12, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
            cell = new PdfPCell(new Paragraph(br.line_13, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
            cell = new PdfPCell(new Paragraph(br.line_14, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
            cell = new PdfPCell(new Paragraph(br.line_15, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
            cell = new PdfPCell(new Paragraph(br.line_16, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
            cell = new PdfPCell(new Paragraph(br.line_17, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
            cell = new PdfPCell(new Paragraph(br.line_18, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
            cell = new PdfPCell(new Paragraph(br.line_19, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
            cell = new PdfPCell(new Paragraph(br.line_20, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
          
            cell = new PdfPCell(new Paragraph(br.line_21, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
            cell = new PdfPCell(new Paragraph(br.line_22, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
            cell = new PdfPCell(new Paragraph(br.line_23, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
            cell = new PdfPCell(new Paragraph(br.line_24, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
            cell = new PdfPCell(new Paragraph(br.line_25, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
            cell = new PdfPCell(new Paragraph(br.line_25, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
            cell = new PdfPCell(new Paragraph(br.line_27, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
            cell = new PdfPCell(new Paragraph(br.line_28, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
            cell = new PdfPCell(new Paragraph(br.line_29, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
            cell = new PdfPCell(new Paragraph(br.line_30, smallfont)); cell.Border = 0; gen_details.AddCell(cell);


            cell = new PdfPCell(new Paragraph(br.line_31, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
            cell = new PdfPCell(new Paragraph(br.line_32, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
            cell = new PdfPCell(new Paragraph(br.line_33, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
            cell = new PdfPCell(new Paragraph(br.line_34, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
            cell = new PdfPCell(new Paragraph(br.line_35, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
            cell = new PdfPCell(new Paragraph(br.line_35, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
            cell = new PdfPCell(new Paragraph(br.line_37, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
            cell = new PdfPCell(new Paragraph(br.line_38, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
            cell = new PdfPCell(new Paragraph(br.line_39, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
            cell = new PdfPCell(new Paragraph(br.line_40, smallfont)); cell.Border = 0; gen_details.AddCell(cell);

            cell = new PdfPCell(new Paragraph(br.line_41, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
            cell = new PdfPCell(new Paragraph(br.line_42, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
            cell = new PdfPCell(new Paragraph(br.line_43, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
            cell = new PdfPCell(new Paragraph(br.line_44, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
            cell = new PdfPCell(new Paragraph(br.line_45, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
            cell = new PdfPCell(new Paragraph(br.line_45, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
            cell = new PdfPCell(new Paragraph(br.line_47, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
            cell = new PdfPCell(new Paragraph(br.line_48, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
            cell = new PdfPCell(new Paragraph(br.line_49, smallfont)); cell.Border = 0; gen_details.AddCell(cell);
           

            return gen_details;

        }
         
         private PdfPTable getFooter(Brief br)
        {
            var footer = new PdfPTable(2);
            footer.TotalWidth = 500.0F;
            footer.LockedWidth = true;
            footer.DefaultCell.BackgroundColor = footer_background_color;


            cell = new PdfPCell(new Paragraph("CRD 2943.78545", new iTextSharp.text.Font(iTextSharp.text.Font.HELVETICA, 5.0F, iTextSharp.text.Font.NORMAL)));
            cell.Border = 0;
            cell.BackgroundColor = footer_background_color;
            cell.Colspan = 2;



            footer.AddCell(cell);

            cell = new PdfPCell(new Paragraph("Printed at: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), smallfont));
            cell.Border = 0;
            cell.BackgroundColor = footer_background_color;
            cell.Colspan = 2;
            footer.AddCell(cell);

            cell = new PdfPCell(new Paragraph("by: " + br.line_50, smallfont));
            cell.Border = 0;
            cell.BackgroundColor = footer_background_color;
            cell.Colspan = 2;
            footer.AddCell(cell);


            return footer;
        }
    }

    }
