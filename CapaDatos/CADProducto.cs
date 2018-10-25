using CapaDatos.DSTesisFacturacionTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CADProducto
    {
        private static FAC_PRODUCTOTableAdapter adaptador = new FAC_PRODUCTOTableAdapter();

        public static DSTesisFacturacion.FAC_PRODUCTODataTable GetData()
        {
            return adaptador.GetData();
        }

        public static void ProductInsert(
            string PRO_CODIGO,
            int PRO_STOCKS,
            string PRO_DESCRIPCION,
            string PRO_ENVASES,
            string PRO_UNIDAD_MEDIDA,
            decimal PRO_PRECIO_COMPRA,
            bool PRO_TIENE_IVA,
            decimal PRO_PRECIO_VENTA,
            bool PRO_ACTIVO)
        {
            adaptador.ProductInsert(
                PRO_CODIGO,
                PRO_STOCKS,
                PRO_DESCRIPCION,
                PRO_ENVASES,
                PRO_UNIDAD_MEDIDA,
                PRO_PRECIO_COMPRA,
                PRO_TIENE_IVA,
                PRO_PRECIO_VENTA,
                PRO_ACTIVO);
        }

        public static void ProductUpdate(
            string PRO_CODIGO,
            int PRO_STOCKS,
            string PRO_DESCRIPCION,
            string PRO_ENVASES,
            string PRO_UNIDAD_MEDIDA,
            decimal PRO_PRECIO_COMPRA,
            bool PRO_TIENE_IVA,
            decimal PRO_PRECIO_VENTA,
            bool PRO_ACTIVO,
            int PRO_ID)
        {
            adaptador.ProductUpdate(
                PRO_CODIGO,
                PRO_STOCKS,
                PRO_DESCRIPCION,
                PRO_ENVASES,
                PRO_UNIDAD_MEDIDA,
                PRO_PRECIO_COMPRA,
                PRO_TIENE_IVA,
                PRO_PRECIO_VENTA,
                PRO_ACTIVO,
                PRO_ID);
        }

        public static void ProductDelete(int PRO_ID)
        {
            adaptador.ProductDelete(PRO_ID);
        }
    }
}

