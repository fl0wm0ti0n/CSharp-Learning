namespace VierGewinnt.Core
{
    public class Spielstein
    {

        private readonly Farbe _farbe;
        private readonly string _spielerName;


        /// <summary>
        ///     Ctor.
        /// </summary>
        /// <param name="farbe">Farbe</param>
        /// <param name="spielerName">String</param>

        public Spielstein(Farbe farbe, string spielerName)
        {

            _farbe = farbe ?? throw new System.ArgumentNullException(nameof(farbe));
            _spielerName = spielerName ?? throw new System.ArgumentNullException(nameof(spielerName));

        }


        /// <summary>
        ///     Property - Farbe.
        /// </summary>

        public Farbe Farbe
        {
            get { return _farbe; }
        }


        /// <summary>
        ///     Property - Spielername.
        /// </summary>

        public string SpielerName
        {
            get { return _spielerName; }
        }
    }
}