using System;
using System.Reflection;

namespace Thomas.Irwin.Ryan.Falcon.Lab6.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}