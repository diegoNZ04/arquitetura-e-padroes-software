namespace design_patterns_console.UML.Examples;

public interface IControleRemoto
{
    public void Play();
    public void Pause();
}

public interface IControleSom : IControleRemoto
{
    public void MudarRadio();
}

public class Blueray : IControleRemoto
{
    public void Pause()
    {
        throw new NotImplementedException();
    }

    public void Play()
    {
        throw new NotImplementedException();
    }
}

public class Som : IControleSom
{
    public void MudarRadio()
    {
        throw new NotImplementedException();
    }

    public void Pause()
    {
        throw new NotImplementedException();
    }

    public void Play()
    {
        throw new NotImplementedException();
    }
}
