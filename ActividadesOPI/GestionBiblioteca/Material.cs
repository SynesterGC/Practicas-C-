using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using Biblioteca2nd;

public abstract class Material
{
    public DateTime PublishYear { get; set; }
    public string? Title { get; set; }
    public string? Autor { get; set; }
    public string? Description { get; set; }
    public bool IsAvailable { get; set; } = true;
    public abstract void ObtainDescription();
}