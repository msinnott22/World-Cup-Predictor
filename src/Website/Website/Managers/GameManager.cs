using System;
using Data.Dto;
using Data.Interfaces;
using Website.Interfaces;
using Website.Models.Input;

namespace Website.Managers
{
    public class GameManager : IGameManager
    {
        private readonly IWriteStore _writeStore;

        public GameManager(IWriteStore writeStore)
        {
            _writeStore = writeStore;
        }

        public bool CreateNewGame(NewGameModel model)
        {
            var helper = new Helpers();
            var newGame = new Game()
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                Created = DateTime.Now,
                AdminUserId = model.AdminUserId,
                TotalPoints = 0,
                JoinCode = helper.GenerateCode()
            };

            _writeStore.Insert(newGame);

            return true;
        }
    }
}