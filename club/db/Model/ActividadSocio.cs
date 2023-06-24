using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace clubApp.db
{
    [Table(Name = "actividad_socio")]
    public partial class ActividadSocio
    {
        #region variables locales
        private int _codigo;
        private int _nro_socio;
        private int _cod_act;
        private DateTime _fecha_inicio;
        private DateTime? _fecha_fin;

        private Actividad _actividad = null;
        private Socio _socio = null;
        private TipoActividad _tipo_actividad = null;
        #endregion

        #region propiedades publicas

        [Propiedad(Name = "codigo", Tipo = typeof(int), EsAutoGenerado = true, EsClave = true)]
        public int Id
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        [Propiedad(Name = "cod_act", Tipo = typeof(int))]
        public int CodActividad
        {
            get { return _cod_act; }
            set { _cod_act = value; }
        }


        [Propiedad(Name = "nro_socio", Tipo = typeof(int))]
        public int NroSocio
        {
            get { return _nro_socio; }
            set { _nro_socio = value; }
        }

        [Propiedad(Name = "fecha_inicio", Tipo = typeof(DateTime))]
        public DateTime FechaInicio
        {
            get { return _fecha_inicio; }
            set { _fecha_inicio = value; }
        }
        [Propiedad(Name = "fecha_fin", Tipo = typeof(DateTime?))]
        public DateTime? FechaFin
        {
            get { return _fecha_fin; }
            set { _fecha_fin = value; }
        }

        #endregion
        // -- TODO --

        #region Relaciones con otras entidades
        // relacion con Actividad
        public Actividad ActividadActividadSocio
        {
            get
            {
                if (_tipo_actividad == null && this._cod_act != 0)
                {
                    _actividad = new Actividad();
                    _actividad = Actividad.FindByKeyStatic(this._cod_act);
                }
                return _actividad;
            }
            set { _actividad = value; }
        }
        // relacion con Socio
        public Socio SocioActividadSocio
        {
            get
            {
                if (_socio == null && this._nro_socio != 0)
                {
                    _socio = new Socio();
                    _socio = Socio.FindByKeyStatic(this._nro_socio);

                }
                return _socio;
            }
            set { _socio = value; }
        }
        // relacion con TipoActividad(?)
        public TipoActividad TipoActividadActividadSocio
        {
            get
            {
                if (_tipo_actividad == null && this._cod_act != 0)
                {
                    _tipo_actividad = new TipoActividad();
                    _tipo_actividad = TipoActividad.FindByKeyStatic(this._cod_act);
                }
                return _tipo_actividad;
            }
            set { _tipo_actividad = value; }
        }
       

        #endregion
    }

}
