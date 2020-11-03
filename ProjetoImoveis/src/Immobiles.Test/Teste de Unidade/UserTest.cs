using Immobiles.Domain;
using Immobiles.Domain.Models;
using Immobiles.Domain.Models.Validation;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Immobiles.Test.Teste_de_Unidade
{
    public class UserTest
    {
        [Fact]
        public void Usuario_DeveCriarAnuncio()
        {
            //arrange
            var user = new User(Guid.NewGuid(), "italonleite", "italonleite@gmail.com", "123");
            var address = new Address(Guid.NewGuid(), "21210250", "sds", "xyza", "pancas", "es");
            var immobile = new Immobile(Guid.NewGuid(), EType.COMERCIAL, address);

            //act
            var announcement = user.CreateAnnouncement(Guid.NewGuid(), 1, 1, 1, 1, 1, 1, "description", 100, user, immobile);

            //assert
            Assert.NotNull(announcement);
            Assert.IsType<Announcement>(announcement);

        }
        [Fact]
        public void Usuario_NovoUsuario_DeveEstarValido()
        {
            //arrange
            User user = new User(Guid.NewGuid(), "italonleite", "italonleite@gmail.com", "123");
            UserValidation uservalidation = new UserValidation();

            //act
            var result = uservalidation.IsValid(user);
          
            //assert
            Assert.True(result);


        }
    }
}
