using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ericL_SequenceCompleted_SpawnBlock : MonoBehaviour {

	//INSTRUCTIONS:   place the SequenceBlocks.cs script onto the block to manage the 'key' blocks to be placed in a sequence
	//                you will be able to manage the inspector from the block with the SequenceBlocks.cs script

	//                BlockInSequence.cs is to be placed on the TRIGGER of a block
	//                blocks with the BlockInSequences.cs script on them will be placed in the order they are entered into the SequenceBlocks.cs inspector
	//                this order will be how to unlock the 'completed' task

	//                the reward for completing a task will be from ANY gameobject's script that has a function name of 'reward'
	//                the gameobject containing the script with 'reward' must be placed within the SequenceBlocks.cs inspector

	//                the 'reward' function is called throught the function <gameObjectName>.SendMessage(" nameofmethod ");

	//    BELOW - this is an example of the reward function that is called, in this case, it summons the end block
	//            other uses of the function can be used to trigger other events


	public GameObject spawnLocation;
	public GameObject spawnBlock;

	void reward()
	{
		Instantiate (spawnBlock, spawnLocation.transform.position, spawnLocation.transform.rotation);
	}

}
