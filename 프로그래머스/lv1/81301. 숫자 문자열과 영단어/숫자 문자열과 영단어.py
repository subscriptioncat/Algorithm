def solution(s):
    num_list = ['zero', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine']
    for i, j in enumerate(num_list):
        s = s.replace(j,str(i))
    return int(s)