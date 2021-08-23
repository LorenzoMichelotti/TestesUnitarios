using Data.Context;
using Data.Models;
using Data.Repository;
using System;
using Xunit;

namespace TesteData
{
    public class TesteDatinha
    {
        [Fact]
        public void TesteInstanciaBase()
        {
            Action a = () => Activator.CreateInstance<Base>();
            Assert.Throws<MissingMethodException>(a);
        }
        [Fact]
        public void TesteId()
        {
            int i = 10;
            Afolou a = new Afolou();
            a.Id = i;
            Assert.NotEqual(0, a.Id);
        }
        [Fact]
        public void TesteString()
        {
            string s = "afdhafdh";
            Afolou a = new Afolou();
            a.Nome = s;
            a.Edition = s;
            Assert.NotEqual("", a.Nome);
            Assert.NotEqual("", a.Edition);
        }
        [Fact]
        public void TesteInstanciaContext()
        {
            AfolouContext c = Activator.CreateInstance<AfolouContext>();
            Assert.IsAssignableFrom<AfolouContext>(c);
        }
        [Fact]
        public void TesteCreate()
        {
            AfolouRepo r = Activator.CreateInstance<AfolouRepo>();
            Afolou a = Activator.CreateInstance<Afolou>();
            a.Nome = "O Original";
            a.Edition = "Deluxe";
            r.Create(a);

            Assert.NotEqual(0, a.Id);
        }
    }
}
