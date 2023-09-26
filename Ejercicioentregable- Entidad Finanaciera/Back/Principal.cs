﻿namespace Back
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
        public void RealizarDeposito(double monto)
        { 
            using (var context = new ApplicationDbContext()) 
            {
                Cuenta_Bancaria nuevodeposito = new Cuenta_Bancaria();
                if (monto > 0)
                {
                    nuevodeposito.saldo += monto;
                }
                else 
                {
                    return;//"ingrese otro monto";
                }
                context.SaveChanges();
            }
               
        }
        public void RealiarExtraccion(double monto) 
        {
            using (var context = new ApplicationDbContext())
            {
                Cuenta_Bancaria nuevaextraccion = new Cuenta_Bancaria();
                if (monto > 0 && monto <= nuevaextraccion.saldo)
                {
                    nuevaextraccion.saldo -= monto;
                }
                else if (monto > 0 )
                {
                    return;//"ingrese un monto mayor a cero";
                }
                else 
                { 
                    return;//"saldo insuficiente" 
                }
                context.SaveChanges();

            }
        }
        public void RealizarTransferencia(Cuenta_Bancaria cuentaDestino, double monto) 
        {
            using (var context = new ApplicationDbContext())
            {
                Cuenta_Bancaria cuentaTitular = new Cuenta_Bancaria();
                if (monto > 0 && monto <= cuentaTitular.saldo)
                {
                    cuentaTitular.saldo -= monto;
                }
                else if (monto > 0)
                {
                    return;//"ingrese un monto mayor a cero";
                }
                else
                {
                    return;//"saldo insuficiente" 
                }
                context.SaveChanges();
            }
        public void PagarTarjetaCredito( ) { }
        public void GenerarResumenTarjeta( ) { }




    }
}