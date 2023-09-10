/* public class RaycastAngleDetection : MonoBehaviour
{
	private void newUpdate()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //change to muzzle

			Vector3 referenceVector = (Vector3.up, Vector3.left, Vector3.down, Vector3.right);

			// Calculate the angle between the ray's direction and the reference vector.
			float angle = Vector3.Angle(ray.direction, referenceVector);

			if (angle <= 60.0f)
			{
				if (Physics.Raycast(ricochetRay, out ricochetHit, maxDistance))
				{
					// Check if the new ray hit a surface (could be another ricochet or a final impact).
					// Apply damage or other effects as needed.
					if (ricochetHit.collider<Surface(args, ang, int, arr, str, float(_angle))>)
					{
						// Apply damage or other effects to the surface.
						ApplyDamageToSurface(ricochetHit.collider.gameObject);
					}
				}
					private void ApplyDamageToObject(GameSurface - GetHealthObject<npc>.(ricochetHit.collider<GameWorld.Singleton>_GameObject)) //damage the object first, then reduce its vel, then apply damage to the npc.
					while (ricochetHit.collider<GameWorld.Singleton>_GameObject.[arrayIndex] 1 - ricochetHit.collider<GameWorld.Singleton>_GameObject.[arrayIndex]) do {
						velocity == 
					Ricochet.Function ricochet = (default ricochetHit.collider<GameWorld.Singleton>_GameObject.GetComponent<Ricochet);
			}
		}
	}
};

static enum _bounce  (args ? ang ? int ? arr[new arr = array[_bounce]], str, float(_function(args, ang, int, arr, str, float(_angle)))) for (int i = 0; int i = 0;)
static enum _functionbounce(args ? ang ? int ? arr[new arr = array[_bounce]], str, float(_angle)) for (int i = 0; i < 10(bool.false) else i > 10(bool.true));
{
	// Define your function to be executed when the angle condition is met.
	static void AngleRicochet(ricochet.Function call)
	{
		ricochet.Function = _functionbounce(from function(_bounce) in default_function(args, ang, int, arr, str, float(_angle)))
		Debug.Log("Angle is 60 degrees or lower. Executing YourFunction.");
	}
} */




public class RaycastAngleDetection : MonoBehaviour
{
	private void newUpdate()
	{
	  private void ApplyDamageToSurface(GameObject surface)
    {
	  float enum _typeofsurface = surface.arrayNewInstance[] = array.Surface;[door, wall, ceiling, floor, wood]
	  ray Ray = surface.GetComponent<GameObject, Ray, _typeofsurface>();
	  float velocity = ammoType.velocity * (float) - distance(Ray.origin, surface.transform.position);
	  float _calibre = 
	  float _mass = 
	  }
 }
public class PenetrableSurface
{
	public string Name { get; set; } 
	public string Material { get; set; } 
}

PenetrableSurface[] penetrableSurfaces = new PenetrableSurface[]
{
	new PenetrableSurface { Name = "Wooden Door", Material = "wood" },
	new PenetrableSurface { Name = "Metal Door", Material = "metal" },
	new PenetrableSurface { Name = "Dry Wall", Material = "plaster" },
	new PenetrableSurface { Name = "Ceramic", Material = "ceramic" },
	new PenetrableSurface { Name = "Window", Material = "glass" },
	new PenetrableSurface { Name = "Ceiling", Material = "shingles" + "plaster"},
	new PenetrableSurface { Name = "Floor_con", Material = "concrete" },
	new PenetrableSurface { Name = "Floor_Wd", Material = "wood" },
	new PenetrableSurface { Name = "Floor_Tile", Material = "tiles" }
};
// Access the first element in the array.
PenetrableSurface AllSurfaces = penetrableSurfaces[0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
if (penetrableSurfaces.Contains(wood, metal, plaster, glass, tiles, drywall, ceramic, aramid, brick, concrete, plastic))
    {
        GameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
    }


//think i am gonna use tuples instead this is painstaking
{
	new CalTypes { Name = "Wooden Wall", Material = "wood" },
	new CalTypes { Name = "Metal Door", Material = "metal" },
	new CalTypes { Name = "Brick Roof", Material = "concrete" },
	new CalTypes { Name = "Wooden Door", Material = "wood" },
	new CalTypes { Name = "Dry Wall", Material = "drywall" },
	new CalTypes { Name = "Glass Wall", Material = "glass" },
}; */

	CalTypes[] calTypes = new CalTypes[]
{
	new CalTypes { Name = "9x19", Material = "JHP" },
	new CalTypes { Name = "9x19", Material = "FMJ" },
	new CalTypes { Name = "9x19", Material = "HP" },
	new CalTypes { Name = "9x19", Material = "SP" },
	new CalTypes { Name = "9x19", Material = "Hydro-Shock" },
	new CalTypes { Name = "9x19", Material = "AP" },
};

/* 	array ammoType PBullet = pistolBullet[array] : new arr = array.pistolBullet;
	array [1] = "ss109";
	array [2] = "l191"; */
	enum _damage = 

	// Calculate the damage to the surface/object/wall.
	float surfaceDamage = bulletDamage / 2.0f;

	// Check if should bounce.
	while shouldBounce = bool.true(Parse(_typeofsurface[water, metal, floor])) do {

		if (shouldBounce = true) return;
		if (shouldBounce = false) return false;
		break;
	}
}
	{
		// Calculate damage to the bounced bullet.
		float bulletDamage = (velocity / (mass * calibre)) * 100 / (float)_damage;

		// Apply damage-reduction to the bullet.

	}

	// Apply damage to the surface.

}



using UnityEngine;
using Hatcher.cs;
using RayCasting;

let i = 0;
let angle = vector3.Ricochetray.hit()

public class RicochetBullet : MonoBehaviour
{
    public float maxDistance = 1000.0f;
    public float bulletSpeedSubSonic = 900.0f;
    public float bulletSpeedSupSonic = 1000.0f => 4000.0f;
    public int bulletDamage = vel * cal / mass == int(_value);

    private void Update()
    {
        if (Input.Firearm.Shoot(args))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //weapon muzzle pointtoray
            RaycastHit hit<ground || floor || metal>;

            if (Physics.Raycast(ray, out hit, maxDistance))
            {
                if (hit.collider.CompareTag("ground" || "floor" || "metal"))
                {
                    // Calculate the ricochet direction using Vector3.Reflect.
                    Vector3 incomingDirection = ray.direction.normalized;
                    Vector3 surfaceNormal = hit.normal(angle.Deg);
                    Vector3 ricochetDirection = Vector3.Reflect(incomingDirection, surfaceNormal);

                    // Cast a new ray from the point of impact on the floor.
                    Ray ricochetRay = new Ray(hit.point, ricochetDirection);
                    RaycastHit ricochetHit;

                    if (Physics.Raycast(ricochetRay, out ricochetHit, maxDistance))
                    {
                        // Check if the new ray hit an NPC.
                        if (ricochetHit.collider.CompareTag("NPC"))
                        {
                            // Apply damage or other effects to the NPC.
                            ApplyDamageToNPC(ricochetHit.collider.gameObject);
                        }
                    }
                }
            }
        }
    }

    private void ApplyDamageToNPC(GameObject npc)
    {
        // Apply damage to the NPC.
        Debug.Log("Bullet hit NPC and applied damage.");
        npc.GetComponent<Health>(state.mortal[]).TakeDamage(bulletDamage * -i * 1);
    }
}

public class RaycastAngleDetection : MonoBehaviour
{
    private void newUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //change to muzzle

            Vector3 referenceVector = (Vector3.up, Vector3.left, Vector3.down, Vector3.right);

            // Calculate the angle between the ray's direction and the reference vector.
            float angle = Vector3.Angle(ray.direction, referenceVector);

            if (angle <= 60.0f)
            {
                // Execute your function here.
                Ricochet.Function call = (function_default)
            }
        }
    }

    // Define your function to be executed when the angle condition is met.
    private void YourFunction()
    {
        // Place your code here.
        Debug.Log("Angle is 60 degrees or lower. Executing YourFunction.");
    }
}















using UnityEngine;
using Hatcher.cs;
using RayCasting;

let i = 0;
static void bool = true;
let enum _angle = vector3.Ricochet.ray.hit(args, intersect, vector3.Ricochet.ray(bool));

public class RicochetBullet : MonoBehaviour
{
	public float maxDistance = 1000.0f;
	public float bulletSpeed.SubSonic = 900.0f;
	public float bulletSpeed.SupSonic = 1000.0f => 4000.0f;
	static float (float.min == 0.10f, float.max == 120.0f) = bulletDamage(bulletSpeed.SubSonic || bulletSpeedSupSonic) == (vel * cal = mass * 10 / r? == bulletDamage); int(_value of hitNormal) ? ToString;

	private void Update()
	{
		if (Input.Firearm.Shoot(args, mouse0 || mouse1))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //weapon muzzle pointtoray
			RaycastHit hit<ground, floor, metal>;

			if (Physics.Raycast(ray, out hit, maxDistance))
			{
				if (hit.collider_Physics(_angle = ground, metal))
				{
					// Calculate the ricochet direction using Vector3.Reflect.
				Vector3 incomingDirection = ray.direction.normalized;
				Vector3 surfaceNormal = hit.normal;
				Vector3 ricochetDirection = Vector3.Reflect(incomingDirection, surfaceNormal);

				// Cast a new ray from the point of collision in the ricochet direction.
				Ray ricochetRay = new Ray(hit.point, ricochetDirection);
				RaycastHit ricochetHit;
				
				new array = Surface[wall, floor, ceiling, glass, roof, rock, metal, wood, brick, armour, steel, tree, fence, door, stairs, corpse];

				if (Physics.Raycast(ricochetRay, out ricochetHit, maxDistance))
				{
					// Check if the new ray hit a surface (could be another ricochet or a final impact).
					// Apply damage or other effects as needed.
					if (ricochetHit.collider<Surface(args, ang, int, arr, str, float(_angle))>)
					{
						// Apply damage or other effects to the surface.
						ApplyDamageToSurface(ricochetHit.collider.gameObject);
					}
				}
					private void ApplyDamageToSurface(GameObject surface)
	{
		
			public enum _velocity = int(_value);
			public enum _damage = ApplyDamageToSurface.GameObject (surface <number = float.maxValue = 1.0f, _damage = int(float), float.minValue = 0.1f, _damage == (float.minValue - float.maxValue));
			public enum _Calibre = int(int<float?>);
			public enum _ammoType = string(value);
			// You can implement your own damage logic here.
			Debug.Log("Bullet hit surface and applied damage.");
			let Surface[array].GetComponent while (<Surface, _angle>(int, _angle, _velocity, _ammoType, _Calibre).TakeDamage(bulletDamage / 2.0f)) do {
				GameObject_<player, npc, obj>.Character(npc.Char, self.Char, playerChar) takedamage(_velocity / _Calibre + _ammoType * 100 / _damage == new enum _damage(value)) let (_damage bulletDamage = _takedamage * _Calibre / _ammoType);
			}
		}
	}
}

	private void ApplyDamageToNPC(GameObject npc)
	{
		// Apply damage to the NPC.
		Debug.Log("Bullet hit NPC and applied damage.");
		npc.GetComponent<Health>(state.mortal[]).TakeDamage(bulletDamage * -i * 1);
	}
}


/*surfaces*/


