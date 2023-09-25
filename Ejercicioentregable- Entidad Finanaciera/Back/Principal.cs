namespace Back
{
    public class Principal
    {
        ApplicationDbContext context = new ApplicationDbContext();


        // Metodos
        public void AgregarCliente(Cliente cliente) 
        {
            using (var context = new ApplicationDbContext())
            {
               var nuevoCliente = new Cliente { nombre = cliente.nombre, apellido = cliente.apellido, dni = cliente.dni};
               context.Clientes.Add(nuevoCliente);
               context.SaveChanges();
            }
        }
        public void CrearCuentaBancaria(Cuenta_Bancaria cuentaBancaria) 
        {
            using (var context = new ApplicationDbContext())
            {
                var nuevaCuentaBancaria = new Cuenta_Bancaria { titular = cuentaBancaria.titular, numeroCuenta= cuentaBancaria.numeroCuenta,saldo = cuentaBancaria.saldo, tipo = cuentaBancaria.tipo};
                context.CuentasBancarias.Add(nuevaCuentaBancaria);
                context.SaveChanges();
            }
        }
        public void EmitirTarjetaCredito(Cliente cliente) 
        {
             
            using (var context = new ApplicationDbContext())
            {

                var nuevaTarjetaDeCredito = new Tarjeta_de_Crédito ();
                context.TarjetasDeCredito.Add(nuevaTarjetaDeCredito);
                context.SaveChanges();
            }
        }
        public void PausarTarjetaCredito() 
        {
            using (var context = new ApplicationDbContext())
            {
                Tarjeta_de_Crédito pausarTarjeta = new Tarjeta_de_Crédito();
                var tarjetaBuscada = context.TarjetasDeCredito.Find(x => x.idTarjetaCredito == idTarjetaCredito);
                tarjetaBuscada.estado = tarjetaBuscada.estado;
                context.SaveChanges();
            }
        }
        public void RealizarDeposito() { }
        public void RealiarExtraccion() { }
        public void RealizarTransferencia(/*string valor*/) { }
        public void PagarTarjetaCredito( ) { }
        public void GenerarResumenTarjeta( ) { }




    }
}