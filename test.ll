declare i32 @printf(i8*, ...)
declare i32 @scanf(i8*, ...)
declare i32 @puts(i8*)
@strpi = constant [4 x i8] c"%d\0A\00"
@strpd = constant [4 x i8] c"%f\0A\00"
@strps = constant [4 x i8] c"%s\0A\00"
@strsi = constant [3 x i8] c"%d\00"
@strsd = constant [4 x i8] c"%lf\00"

@a = global i32 0
define i32 @main() nounwind {
%v = alloca <2 x i32>
store <2 x i32> zeroinitializer, <2 x i32>* %v 
%1 = load <2 x i32>, <2 x i32> * %v 
%2 = insertelement <2 x i32> %1, i32 10, i32 0 
store<2 x i32> %2, <2 x i32> * %v 
%3 = load <2 x i32>, <2 x i32> * %v
%4 = extractelement <2 x i32> %3, i32 0
%5 = call i32 (i8*, ...) @printf(i8* getelementptr inbounds ([4 x i8], [4 x i8]* @strpi, i32 0, i32 0), i32 %4)
%6 = load <2 x i32>, <2 x i32>* %v 
%7= extractelement <2 x i32> %6, i32 0 
%8 = add i32 2, %7
store i32 %8, i32* @a
%9 = load i32, i32* @a
%10= call i32 (i8*, ...) @printf(i8* getelementptr inbounds ([4 x i8], [4 x i8]* @strpi, i32 0, i32 0), i32 %9)
%11 = load <2 x i32>, <2 x i32> * %v 
%12 = insertelement <2 x i32> %11, i32 10, i32 0 
store<2 x i32> %12, <2 x i32> * %v 
%13 = load <2 x i32>, <2 x i32> * %v 
%14 = insertelement <2 x i32> %13, i32 13, i32 1 
store<2 x i32> %14, <2 x i32> * %v 
%15 = load <2 x i32>, <2 x i32> * %v
%16 = extractelement <2 x i32> %15, i32 1
%17 = call i32 (i8*, ...) @printf(i8* getelementptr inbounds ([4 x i8], [4 x i8]* @strpi, i32 0, i32 0), i32 %16)
  ret i32 0
}
