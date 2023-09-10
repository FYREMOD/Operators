
using UnityEngine;

public namespace StoppingPower_Hatcher(int, var, str, bool) : MonoBehaviour

public variables[stop, m, a, r, v]
let hatcher Hatcher = StoppingPower.Hatcher
let stop = stoppingPower.Hatcher
let m = [momentum(string[(foot-lbs)]] 
let a = [area(ammunitionType)] 
let r = [residual.energy]
let v = [ammunitionType.velocity(velocity) = stoppingPower.velocity(rsp - r))]

 void start()
 {
	static void Hatcher[] : new Hatcher[rsp, m, a, r, v];
		return Hatcher.r(args) 
	else if Hatcher.m(args) {debugprint("Hatcher.m(args) returned "err". Attempting Hatcher.r now");
	catch(Hatcher.r - Hatcher.m (err(string)) return Hatcher.m(args)) {debugprint("Hatcher.r"}
	throw err;
	else return true; //just trying something stupid
	}
	}
	/*stopping power using the "Hatcher Formula"*/
    static void hatcher = Hatcher(StoppingPower.Hatcher(let rsp = stoppingPower.Hatcher, let m = momentum(string[(foot-lbs)], let a = area(ammunitionType), let r = residual.energy, let v = ammunitionType.velocity(Vel) = stoppingPower.Vel<rsp - r>)) return true;)
	

{
	public float bulletMassInGrains = 150.0f; // Mass of the bullet in grains.
	public float bulletVelocityInFps = 3500.0f; // Initial velocity of the bullet in fps.
	public float maxDistance = 1000.0f; // Maximum raycast distance.
	public float velocityDropDistance = 200.0f; // Distance for exponential velocity drop.

	private void Update()
	{
		// Cast a ray from the player's position in the desired direction.
		Vector3 playerPosition = transform.position;
		Vector3 rayDirection = transform.forward;
		float remainingDistance = maxDistance;
		RaycastHit rayHit = hit;
		
		Pentrable[] pentrables = GameObject.FindObjectsOfType<Pentrable>(wall, bushes, door, stairs, glass, roof, ceiling);
		while (Pentrable.GameObject_type (let roof == ceiling && let wall == door)) do {
			let bulletVelocityInFps = velocity;
			bulletVelocityInFps(int) i = 0; 
			get ray.velocity[arr] - remainingDistance(bulletType + bulletVelocity == arr(int));
			bulletVelocityInFps(Vector3 ray.velocity[arr] - remainingDistance(bulletType * bulletVelocity == arr(int)));
		}
	}

		while (remainingDistance > 0f)
		{
			if (Physics.Raycast(playerPosition, rayDirection, out hit, remainingDistance))
			{
				// Check the hit object's properties (e.g., layer or tag) to determine if it's penetrable.
				if (hit.collider.CompareTag("Penetrable"))
				{
					// Calculate the distance traveled up to this hit.
					float distanceTraveled = maxDistance - remainingDistance;

					// Apply exponential velocity drop for every 200 meters. this is placeholder
					int numExponentialDrops = (int)(distanceTraveled / velocityDropDistance);
					float exponentialVelocityDrop = Mathf.Pow(0.9f, numExponentialDrops);

					// Reduce vel based on Hatcher's Formula and exponential drop.
					float stoppingPower = (bulletMassInGrains * bulletVelocityInFps) / 7000.0f;
					float velocityDrop = stoppingPower / distanceTraveled;
					bulletVelocityInFps -= velocityDrop * exponentialVelocityDrop;

					// update remaining distance and continue raycast through the penetrable object.
					remainingDistance = maxDistance - distanceTraveled;
					playerPosition = hit.point + rayDirection * 0.01f; // Offset slightly to prevent self-intersection.
				}
				else if (hit.collider.CompareTag("NPC") || hit.collider.CompareTag("Player"))
				{
					// Handle hits on NPCs or players.
          // finish
					break; // Stop the raycast upon hitting an NPC or player.
				}
			}
			else
			{
				// No hit, exit the loop.
				break;
			}
		}
	}
}
