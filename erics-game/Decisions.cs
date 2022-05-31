using System;
namespace erics_game
{
	public static class Decisions
	{
		/*
		 * Incomplete. This was intended to be the start of the state engine. Ideally just calling "getNext" would have taken the previous and current steps along with
		 * game and player state to return a new "thisStep".
		 */
		static GameStep previousStep = null;
		static GameStep thisStep = null;
		static GameStep nextStep = null;

		public static void getNext()
        {
			if (nextStep != null)
            {


            }

        }

		//private static void updateState(int distance, decimal )
  //      {

  //      }
	}
}

