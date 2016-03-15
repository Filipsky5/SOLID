using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.InterfaceSegregation
{
    public interface IMoves
    {
        void AllIn();
        void AllOut();
    }
    public interface IPlayerTimers
    {
        void PausePlayerTimer(string player);

        void RefreshPlayerTimer(string player);
    }
    public interface IPlayerAdministration
    {
        void AddPlayer(string newPlayer);
        IEnumerable<string> GetPlayerStatus(string player);
         void KickPlayer(string player);
    }
    public interface IPLayerCommunication
    {
        void MessageReceived(string player);
        void Confirm(Request request);
        Response Answer(Request request);

    }

    public class Response { } 

    public class Request { }
}
