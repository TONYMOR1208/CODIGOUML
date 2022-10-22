using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4
{
    public class Profesor:ENTIDAD
    {
        public int horario
        {
            get => default;
            set
            {
            }
        }

        public string departamento
        {
            get => default;
            set
            {
            }
        }

        public string materia
        {
            get => default;
            set
            {
            }
        }

        public string titulo
        {
            get => default;
            set
            {
            }
        }

        public void tomar_asistencia()
        {
            throw new System.NotImplementedException();
        }

        public void calificar()
        {
            throw new System.NotImplementedException();
        }

        public void impartir_clases()
        {
            throw new System.NotImplementedException();
        }

        public void planificar()
        {
            throw new System.NotImplementedException();
        }
    }
}