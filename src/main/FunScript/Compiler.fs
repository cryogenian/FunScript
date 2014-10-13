﻿module FunScript.Compiler

open FunScript

//TODO: Use IoC here. MiniIoC perhaps? 
let private allComponents =
   [  //NOTE: ORDER MATTERS!
      Options.components
      Seqs.components
      Sets.components
      Maps.components
      Lists.components
      Strings.components
      Regexs.components
      Times.components
      Asyncs.components
      ReflectedDefinitions.components
      Arrays.components
      ResizeArrays.components
      Dictionaries.components
      RecordTypes.components
      UnionTypes.components
      Tuples.components
      Logic.components
      LambdaApplication.components
      LetBindings.components
      Arithmetic.components
      Comparison.components
      PrimitiveTypes.components
      ControlFlow.components
      Objects.components
      Reflection.components
      TypeConversions.components
      OtherMappings.components
      CommonOperators.components
   ] |> List.concat

type Compiler =
   static member Compile(expression, ?components, ?noReturn, ?shouldCompress) = 
      let components = defaultArg components []
      let shouldCompress = defaultArg shouldCompress false
      let returnStrat = 
         if defaultArg noReturn false then ReturnStrategies.inplace
         else ReturnStrategies.returnFrom
      let compiler = InternalCompiler.Compiler(allComponents @ components)
      let program = compiler.Compile returnStrat expression
      let reflectedDefs = compiler.Globals
      let block = List.append reflectedDefs program
      if shouldCompress then (AST.Block block).PrintCompressed()
      else (AST.Block block).Print()
      
let compile expr = Compiler.Compile(expr)
let compileWithoutReturn expr = Compiler.Compile(expr, noReturn=true)