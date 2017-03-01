using GameCore;
using TechTalk.SpecFlow;
using Xunit;

namespace GameCre.Specs
{
    [Binding]
    public class PlayerCharacterSteps
    {
        private PlayerCharacter _player;
        [Given(@"I am a new player")]
        public void GivenIamANewPlayer()
        {
            _player = new PlayerCharacter();
        }
        
        [When(@"I take (.*) damage")]
        public void WhenITake0Damage(int damage)
        {
            _player.Hit(damage);
        }
        
        [Then(@"My Health should no be (.*)")]
        public void ThenMyHealthShouldBe(int expectedHealth)
        {
            Assert.Equal(expectedHealth, _player.Health);
        }

       [Then(@"I should be dead")]
        public void ThenIShouldBeDead()
        {
            Assert.Equal(true,_player.IsDead);
        }


    }
}
