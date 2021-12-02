using System;

protected class Endereco
{
    private string rua;

    private int num;

    private string bairro;

    private string cidade;

    private int cep;

    protected void setRua(string rua)
    {
        this.rua = rua;
    }

    protected string getRua()
    {
        return this.rua;
    }

    protected void setNum(int num)
    {
        this.num = num;
    }

    protected int getNum()
    {
        return this.num;
    }

    protected void setBairro(string bairro)
    {
        this.bairro = bairro;
    }

    protected string getBairro()
    {
        return this.bairro;
    }

    protected void setCidade(string cidade)
    {
        this.cidade = cidade;
    }

    protected string getCidade()
    {
        return this.cidade;
    }

    protected void setCep(int cep)
    {
        this.cep = cep;
    }

    protected int getCep()
    {
        return this.cep;
    }

}


// 