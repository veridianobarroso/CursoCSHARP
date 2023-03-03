class Banco
{
    public double saldo;
    public void Saca(double valor) {
    this.saldo -= valor;
    }
    public void Deposita(double valor) {
        this.saldo += valor;
    }
}