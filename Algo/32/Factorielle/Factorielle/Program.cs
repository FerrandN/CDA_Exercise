int n = 6;
int result = 1;

result = factorielle(n, result);

static int factorielle(int _n, int _result)
{
    
    if (_n>0)
    {
        _result = factorielle(_n-1, _result);
        _result = _n * _result;
    }

    return _result;
}
Console.WriteLine(result);