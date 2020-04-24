#include <iostream>
#include <cmath>

using namespace std;

bool IsPrime(int number){
    if (number <= 1) return false;

    int nSquare = ceil(sqrt(number));
    for(int i = 2; i < nSquare; i ++){
        if (number % i == 0)
            return false;
    }
    return true;
}

int main(){
    int num, i = 1, rounded;
    cin >> num;

    double value;
    while((value = pow(num, 1.0/i)) >= 2){
        i++;

        rounded = (int)round(value);
        if (abs(rounded - value) <= 0.000000001f){
            if(IsPrime(rounded)){
                cout << "yes" << endl;
                return 0;
            }
        }
    }
    cout << "no" << endl;   
    return 0;
}
