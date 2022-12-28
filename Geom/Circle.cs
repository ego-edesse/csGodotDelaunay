using System.Collections;
using Godot;

namespace csDelaunay {
	public class Circle {

		public Godot.Vector2 center;
		public float radius;

		public Circle(float centerX, float centerY, float radius) {
			this.center = new Godot.Vector2(centerX, centerY);
			this.radius = radius;
		}

		public override string ToString () {
			return "Circle (center: " + center + "; radius: " + radius + ")";
		}
	}
}