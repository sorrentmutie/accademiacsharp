using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;

namespace LibreriaDaTestare.Test.StepDefinitions
{
    [Binding]
    public class PlayerStepsDefinitions
    {
        private Player player;

        [Given(@"I'm a new player")]
        public void GivenImANewPlayer()
        {
            player = new Player();
        }


        [Given(@"I am an Elf")]
        public void GivenImAnElf()
        {
            player.Race = "Elf";
        }

        [Given(@"I have the following attributes")]
        public void GivenIHaveAttributes(Table table)
        {
            dynamic attributes = table.CreateDynamicInstance();
            player.Race = attributes.Race;
            player.SpecificRaceDamage = attributes.Damage;

            //var race = table.Rows.First(row => row["attribute"] == "Race")["value"];
            //var resistance = table.Rows.First(row => row["attribute"] == "Damage")["value"];
            //player.Race = race;
            //player.SpecificRaceDamage = int.Parse(resistance);
        }


        [When(@"I take (.*) damage")]
        public void WhenITakeDamage(int p0)
        {
            player.Hit(p0);
        }

        //[When(@"I take 40 damage")]
        //public void WhenITake40Damage()
        //{
        //    player.Hit(40);
        //}



        [Then(@"My health should now be (.*)")]
        public void ThenMyHealthShouldNowBe(int p0)
        {
            Assert.AreEqual(p0, player.Health);
        }

        //[Then(@"My health should now be 60")]
        //public void ThenMyHealthShouldNowBe60()
        //{
        //    Assert.AreEqual(60, player.Health);
        //}

        [Then(@"I should be dead")]
        public void IShouldBeDead()
        {
            Assert.True(player.IsDead);
        }
    }
}
