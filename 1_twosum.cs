public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        //declarations
        Dictionary <int,int> _tracker = new Dictionary<int,int> ();
        int [] _solution = new int[2];
        int _arrayLength = nums.Length;

        //validations
        if (nums == null || _arrayLength < 2){
            return _solution;
        }

        //logic
        for(int i = 0; i < _arrayLength; i++){
            
            int _remainder = target - nums[i];
            
            if(_tracker.ContainsKey(_remainder)){
                
                int _trackerIndex; 
                
                _tracker.TryGetValue(_remainder,out _trackerIndex);
                
                
                return _solution = new int[] {_trackerIndex,i};
            }
            
            _tracker[nums[i]] = i;
        }
        
        return _solution;
    }
}