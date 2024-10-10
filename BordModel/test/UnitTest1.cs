namespace BordModel;

public class UnitTest1
{
        [Fact]
        public void GetElement_ShouldReturnTopElement() 
        { 
            // Arrange 
            var stapel = new Stapel<int>(); 

            // Act 
            stapel.duw(1); 

            // Assert 
            Assert.Equal(1, stapel.getElement()); 

        }

        [Fact]
        public void Pak_ShouldRemoveTopElement() 
        { 
            // Arrange 
            var stapel = new Stapel<int>(); 

            // Act 
            stapel.duw(1);  

            // Assert  													  
            Assert.Equal(1, stapel.pak());  

        }
}

