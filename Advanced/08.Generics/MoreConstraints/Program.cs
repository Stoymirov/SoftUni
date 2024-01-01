StreamReader reader = new StreamReader("");

GetResources<StreamReader>(reader);
GetResources<CustomResouce>(new CustomResouce());
void GetResources<T>(T path) where T: IDisposable
{
    using (path)
    path.Dispose();
}


class CustomResouce : IDisposable
{
    public void Dispose()
    {

    }
}