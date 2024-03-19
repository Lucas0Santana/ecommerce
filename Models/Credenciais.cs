using System.ComponentModel.DataAnnotations;

public class Credenciais
{
    private readonly int _id;
    private readonly string _nome;
    private readonly string _email;
    private readonly string _senha;
    private bool _status;

    public int Id => _id;
    public string Nome => _nome;
    [EmailAddress]
    public string Email => _email;
    public string Senha => _senha;
    public bool Status => _status;

    public Credenciais(int id, string nome, string email, string senha, bool status) 
    {
        _id = id;
        _nome = nome;
        _email = email;
        _senha = senha;
        _status = status;
    }

    public void SetStatus()
    {
        _status = !_status;
    }

}
