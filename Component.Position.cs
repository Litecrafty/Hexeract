namespace Hexeract.Component.Position
{
    /// <summary>
    /// Vector is a part of the Component as there will be Entities that has a direction, 
    /// for example Player, Item at ground, etc.
    /// </summary>
    struct Vector
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        /// <summary>
        /// There is a constructor forced to overwrite the struct properties, this is 
        /// used in order to let the developer initialize vectors in an easier way.
        /// </summary>
        /// <param name="x">X direction of the vector</param>
        /// <param name="y">Y direction of the vector</param>
        /// <param name="z">Z direction of the vector</param>
        public Vector(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString() => $"Vector hash: {GetHashCode()}, Vector X: {X}, Vector Y: {Y}, Vector Z: {Z}";
        public override bool Equals(object toCompare) => (toCompare is Vector && this == (Vector) toCompare) ? true : false;

        public static bool operator ==(Vector first, Vector second) => (first.X == second.X && first.Y == second.Y && first.Z == second.Z) ? true : false;
        public static bool operator !=(Vector first, Vector second) => !(first == second);

        public static Vector operator +(Vector first, Vector toAdd)
        {
            first.X += toAdd.X;
            first.Y += toAdd.Y;
            first.Z += toAdd.Z;
            return first;
        }

        public static Vector operator +(Vector first, (int x, int y, int z) toAdd)
        {
            first.X += toAdd.x;
            first.Y += toAdd.y;
            first.Z += toAdd.z;
            return first;
        }

        public static Vector operator +(Vector first, int toAdd)
        {
            first.X += toAdd;
            first.Y += toAdd;
            first.Z += toAdd;
            return first;
        }

        public static Vector operator -(Vector first, Vector toSub)
        {
            first.X -= toSub.X;
            first.Y -= toSub.Y;
            first.Z -= toSub.Z;
            return first;
        }

        public static Vector operator -(Vector first, (int x, int y, int z) toSub)
        {
            first.X -= toSub.x;
            first.Y -= toSub.y;
            first.Z -= toSub.z;
            return first;
        }

        public static Vector operator -(Vector first, int toSub)
        {
            first.X -= toSub;
            first.Y -= toSub;
            first.Z -= toSub;
            return first;
        }

        public static Vector operator *(Vector first, Vector toScale)
        {
            first.X *= toScale.X;
            first.Y *= toScale.Y;
            first.Z *= toScale.Z;
            return first;
        }

        public static Vector operator *(Vector first, (int x, int y, int z) toScale)
        {
            first.X *= toScale.x;
            first.Y *= toScale.y;
            first.Z *= toScale.z;
            return first;
        }

        public static Vector operator *(Vector first, int toScale)
        {
            first.X *= toScale;
            first.Y *= toScale;
            first.Z *= toScale;
            return first;
        }
    }

    /// <summary>
    /// Location is a part of the Component as blocks and other entities will have a location, 
    /// for example Player, Item at ground, etc.
    /// </summary>
    struct Location
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        /// <summary>
        /// There is a constructor forced to overwrite the struct properties, this is 
        /// used in order to let the developer create locations in an easier way.
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        /// <param name="z">Z coordinate</param>
        public Location(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
